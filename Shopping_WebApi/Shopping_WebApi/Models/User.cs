namespace Shopping_WebApi.Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        private string _PhoneNumber;
        private int _MaxLength = 11;
        public string PhoneNumber
        {
            get => _PhoneNumber;
            set => _PhoneNumber = value.Length <= _MaxLength ? value : value.Substring(0, _MaxLength);
        }
        public string Email {  get; set; }
    }
}
