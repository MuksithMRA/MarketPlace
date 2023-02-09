namespace MarketPlace.Dtos
{
public class StoreDTO
{
    public int Id {
        get;
        set;
    }
    public string Title {
        get;
        set;
    } = string.Empty;
    public string Description {
        get;
        set;
    } = string.Empty;
    public string Image {
        get;
        set;
    } = string.Empty;
    public int LocationId {
        get;
        set;
    }
    public virtual LocationDTO Location {
        get;
        set;
    } = new LocationDTO();

    public ICollection<ProductDTO> Products {
        get;
        set;
    }
}
}
