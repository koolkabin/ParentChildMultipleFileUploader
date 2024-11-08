namespace ParentChildMultipleFileUploader.Model
{
    public class ParentChildRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IFormFile Photo { get; set; }
        public List<ChildRequest> Children { get; set; }
    }

    public class ChildRequest
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public IFormFile Photo { get; set; }
    }

}
