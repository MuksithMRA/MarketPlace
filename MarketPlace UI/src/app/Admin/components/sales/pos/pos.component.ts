import { Component, OnInit } from '@angular/core';
import { Category } from 'app/Admin/models/category';
import { Product } from 'app/Admin/models/product';
import { CategoryService } from 'app/Admin/services/category.service';
import { ProductService } from 'app/Admin/services/product.service';

@Component({
  selector: 'app-pos',
  templateUrl: './pos.component.html',
  styleUrls: ['./pos.component.scss']
})
export class PosComponent implements OnInit {

  categories: Category[] = [];
  products: Product[] = [];
  customers: any[] = [];
  selectedCustomer: any;

  constructor(private categoryService: CategoryService, private productService: ProductService) { }

  ngOnInit(): void {
    this.categoryService.getCategories().subscribe((data) => {
      this.categories = data;
    });
    this.productService.getProducts().subscribe((data) => {
      this.products = data;
    });
  }

}
