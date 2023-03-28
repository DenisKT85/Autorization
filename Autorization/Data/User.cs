namespace Autorization.Data
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<string> Logins { get; set; } // если входили через разные соц сети

        // PasswordHash
        // Roles - нужно создать класс
        public string PhoneNumber { get; set; }
        // SecurityStamp: некоторое специальное значение,
        // которое меняется при смене аутентификационных данных, например, пароля
        public int AccessFailedCount { get; set; } // количество неудачных попыток входа
        public bool EmailConfirmed { get; set; } // подтвержден ли емайл
        public bool PhoneNumberConfirmed { get; set; } // подтвержден ли телефон


    }
}
