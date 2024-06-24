namespace LabWorkLibrary
{
    /// <summary>
    /// Класс User, содержащий логин, пароль и роль пользователя
    /// </summary>
    internal class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
