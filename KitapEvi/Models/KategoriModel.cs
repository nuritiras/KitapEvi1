namespace KitapEvi.Models
{
    public class KategoriModel
    {
        public int KategoriId { get; set; }
        public string KategoriAdi{ get; set; }
        List<KitapModel> kitaplistesi=new List<KitapModel>();
    }
}
