using MarketPlace.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Dtos {
public class SubCategoryDTO {
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
    public int BrandId {
        get;
        set;
    }
    public int CategoryId {
        get;
        set;
    }
    public virtual BrandDTO Brand {
        get;
        set;
    } = new BrandDTO();
}
}
