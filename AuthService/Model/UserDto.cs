namespace AuthService.Model
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        //public bool? IsAvailble { get; set; }
        public string Password {  get; set; } 
  
    }
}
