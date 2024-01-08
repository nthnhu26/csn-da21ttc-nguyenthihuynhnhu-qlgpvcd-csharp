using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace GUI
{
    public class GoogleDrive
    {
        private DriveService service;

        public GoogleDrive(string[] scopes, string applicationName)
        {
            UserCredential credential;

            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                var clientSecrets = GoogleClientSecrets.FromStream(stream).Secrets;
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    clientSecrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore("token.json", true)).Result;
            }

            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName,
            });
        }

        public string GetOrCreateFolder(string parentFolderId, string folderName)
        {
            string query = string.Format("'{0}' in parents and mimeType='application/vnd.google-apps.folder' and name='{1}'", parentFolderId, folderName);
            var request = service.Files.List();
            request.Q = query;
            request.Fields = "files(id)";
            var result = request.Execute();

            if (result.Files != null && result.Files.Count > 0)
            {
                return result.Files[0].Id;
            }

            var folderMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = folderName,
                MimeType = "application/vnd.google-apps.folder",
                Parents = new List<string> { parentFolderId }
            };

            var requestCreateFolder = service.Files.Create(folderMetadata);
            requestCreateFolder.Fields = "id";
            var folder = requestCreateFolder.Execute();
            return folder.Id;
        }

        public string UploadFile(string filePath, string folderId)
        {
            try
            {
                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = Path.GetFileName(filePath),
                    Parents = new List<string> { folderId }
                };

                FilesResource.CreateMediaUpload request;
                using (var stream = new FileStream(filePath, FileMode.Open))
                {
                    request = service.Files.Create(fileMetadata, stream, "application/octet-stream");
                    request.Upload();
                }

                // Lấy ID của file sau khi upload
                string uploadedFileId = request.ResponseBody.Id;

                // Xây dựng đường dẫn truy cập đến file từ ID
                string uploadedFileUrl = "https://drive.google.com/file/d/" + uploadedFileId + "/view";

                return uploadedFileUrl;
                //         return uploadedFileId;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ tại đây (ví dụ: ghi log, thông báo lỗi, v.v.)
                Console.WriteLine("Lỗi khi tải file lên Google Drive: " + ex.Message);
                return null; // Hoặc làm gì đó khác tùy thuộc vào yêu cầu của bạn
            }
        }
        public string GetGoogleDriveFileId(string url)
        {
            // Sử dụng biểu thức chính quy để lấy ID
            var regex = new Regex(@"/file/d/(.*?)/");
            Match match = regex.Match(url);

            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            return null;
        }
        public void DeleteFile(string fileId)
        {
            try
            {
                service.Files.Delete(fileId).Execute();
                //return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xóa tệp tin từ Google Drive: " + ex.Message);
                //  return false;
            }
        }
    }
}
