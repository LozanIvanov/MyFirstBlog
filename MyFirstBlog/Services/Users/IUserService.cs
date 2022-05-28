using MyFirstBlog.InputModels.Users;

namespace MyFirstBlog.Services.Users
{
    public interface IUserService
    {
        void Register(RegisterUserInputModel inputModel);

        bool HasUser(string username);
    }
}
