namespace bshbbackend.ModelDto
{
    public class OfficerListdto
    {
        public string Name { get; set; }
        public string? Designation { get; set; }
        public string? details { get; set; }
        public IFormFile? Photo { get; set; }
    }
}
