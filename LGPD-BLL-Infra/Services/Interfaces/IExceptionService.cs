namespace LGPD_BLL_Infra.Services.Interfaces
{
    public interface IExceptionService
    {
        Task Log(Exception ex);

        Task Log(ArgumentException ex);
    }
}
