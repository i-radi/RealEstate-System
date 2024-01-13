namespace API.Base;
public static class Router
{
    public const string SignleRoute = "/{id}";

    public const string root = "api";
    public const string version = "v1";
    public const string Rule = root + "/" + version + "/";

    public static class UserRouting
    {
        public const string Prefix = Rule + "user";
        public const string Create = Prefix + "/create";
        public const string Paginated = Prefix + "/paginated";
        public const string GetByID = Prefix + SignleRoute;
        public const string Edit = Prefix + "/edit";
        public const string Delete = Prefix + "/{id}";
        public const string ChangePassword = Prefix + "/change-password";
    }
    public static class AuthenticationRouting
    {
        public const string Prefix = Rule + "auth";
        public const string SignIn = Prefix + "/sign-in";
        public const string RefreshToken = Prefix + "/refresh-token";
        public const string ValidateToken = Prefix + "/validate-token";
        public const string ConfirmEmail = Prefix + "/confirm-email";
        public const string SendResetPasswordCode = Prefix + "/send-reset-password-code";
        public const string ConfirmResetPasswordCode = Prefix + "/confirm-reset-password-code";
        public const string ResetPassword = Prefix + "/reset-password";
    }
    public static class AuthorizationRouting
    {
        public const string Prefix = Rule + "auth";
        public const string Roles = Prefix + "/roles";
        public const string Create = Roles + "/create";
        public const string Edit = Roles + "/edit";
        public const string Delete = Roles + "/delete/{id}";
        public const string RoleList = Roles + "/role-list";
        public const string GetRoleById = Roles + "/role-by-id/{id}";
        public const string ManageUserRoles = Roles + "/manage-user-roles/{userId}";
        public const string UpdateUserRoles = Roles + "/update-user-roles";
    }
    public static class PropertyRouting
    {
        public const string Prefix = Rule + "property";
        public const string List = Prefix + "/list";
        public const string GetByID = Prefix + SignleRoute;
        public const string Create = Prefix + "/create";
        public const string Edit = Prefix + "/edit";
        public const string Delete = Prefix + "/{id}";
        public const string Paginated = Prefix + "/paginated";
    }
}
