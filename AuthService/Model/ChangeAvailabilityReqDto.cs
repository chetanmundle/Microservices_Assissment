namespace AuthService.Model
{
    public class ChangeAvailabilityReqDto
    {
        public int UserId { get; set; }
        public bool  IsAvailable { get; set; }
    }
}
