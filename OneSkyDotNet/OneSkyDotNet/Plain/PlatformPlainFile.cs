﻿namespace OneSkyDotNet
{
    internal class PlatformPlainFile : IPlatformPlainFile
    {
        private const string FileListAddress = "https://platform.api.onesky.io/1/projects/{project_id}/files";
        private const string FileUploadAddress = "https://platform.api.onesky.io/1/projects/{project_id}/files";
        private const string FileDeleteAddress = "https://platform.api.onesky.io/1/projects/{project_id}/files";

        private const string FileListPageParam = "page";
        private const string FileListPerPageParam = "per_page";

        private const string ProjectIdPlacehoder = "project_id";

        private OneSky oneSky;

        internal PlatformPlainFile(OneSky oneSky)
        {
            this.oneSky = oneSky;
        }

        public string List(int projectId, int page = 1, int perPage = 50)
        {
            return
                this.oneSky.CreateRequest(FileListAddress)
                    .Placeholder(ProjectIdPlacehoder, projectId)
                    .Parameter(FileListPageParam, page)
                    .Parameter(FileListPerPageParam, perPage)
                    .Get();
        }

        public string Upload(int projectId, string file, string fileFormat, string locale = null, bool isKeepingAllStrings = true)
        {
            throw new System.NotImplementedException();
        }

        public string Delete(int projectId, string fileName)
        {
            throw new System.NotImplementedException();
        }
    }
}