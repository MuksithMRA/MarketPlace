﻿

namespace MarketPlace.Dtos {
public class CategoryDTO {
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
    public ICollection<SubCategoryDTO> SubCategories {
        get;
        set;
    }
}
}
