namespace Insurance.Web.Mvc.Models.PolicyViewModels
{
    public class PolicyByClientViewModel
    {
        public int Id { get; set; }
        public ClientViewModel Client { get; set; }
        public PolicyViewModel Policy { get; set; }
    }
}
