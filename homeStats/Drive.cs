using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Configuration;
namespace homeStats
{
   public class Drive
    {       
            static string[] Scopes = { DriveService.Scope.Drive };
            static string ApplicationName = "HomeStats";           

            public  void UploadDb()
            {
            UserCredential credential;

            credential = GetCredentials();

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            string id = this.findFile();
            string path = ConfigurationManager.AppSettings["Path"];
            string filename = "Statistic";
            var mimetype = "application/msaccess";

            var metadata = new Google.Apis.Drive.v3.Data.File() { Name = filename };
            if (id!="notfound") {
                
                FilesResource.UpdateMediaUpload updateRequest;
                using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
                {
                    updateRequest = service.Files.Update(metadata,id, stream, mimetype);
                    updateRequest.Fields = "id";
                    // request.NewRevision = false;
                    updateRequest.Upload();
                }
                return;
            }            
            FilesResource.CreateMediaUpload request;
            using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
            {
                request = service.Files.Create(metadata, stream, mimetype);
                request.Fields = "id";
                // request.NewRevision = false;
                request.Upload();
            }
            return;






        }
        private string findFile()
        {
            string pageToken = null;
            do
            {
                UserCredential credential;

                credential = GetCredentials();

                var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
                var request = service.Files.List();
                request.Q = "mimeType='application/msaccess'";
                request.Spaces = "drive";
                request.Fields = "nextPageToken, files(id, name)";
                request.PageToken = pageToken;
                var result = request.Execute();
                foreach (var file in result.Files)
                {
                    if (file.Name == "Statistic")
                    {                        
                        return file.Id; 
                    }
                }
                pageToken = result.NextPageToken;
            } while (pageToken != null);
            return "notfound";
        }

            private static UserCredential GetCredentials()
            {
                UserCredential credential;

                using (var stream = new FileStream(ConfigurationManager.AppSettings["DrivePath"] +"drive-dotnet-quickstart.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

                    credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    // Console.WriteLine("Credential file saved to: " + credPath);
                }

                return credential;
            }
        }
    
}
