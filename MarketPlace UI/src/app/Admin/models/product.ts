
export interface Product {
    name: string;
    description: string;
    price: number;
    category: string;
    subCategory: string;
    images: string[];
    rating?: number;
    reviews?: string[];
    id: number;
    brand?: string;
    minQuantity: number;
    quantity: number;
    discount: number;
    status: ProductStatus;
    dateAdded: Date;
    dateModified: Date;

}

class ProductStatus {
    ACTIVE = "Active"
    INACTIVE = "Inactive";
    DELETED = "Deleted"
}

