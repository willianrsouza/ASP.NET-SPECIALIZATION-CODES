namespace Infrastructure.CloudServices.Interfaces
{
    public interface IFileStorageService
    {
        void UploadFile(byte[] bytes, string FileName);
    }
}
