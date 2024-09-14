using Main.Abstractions;
using Model;
using Model.Enums;

namespace Main.Services;
public class ApplicationUser : IApplicationUser
{
    private Operator AppOperator => new() {
        Cid = "danie",
        LoginName = @"gandalf\danie",
        Grant = Grants.SuperAdmin,
        Version = DateTime.Now
    };

    #region Implementation of IAppUser

    public Operator GetUser() {
        return AppOperator;
    }

    #endregion
}
