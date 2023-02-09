import { Component, OnInit } from '@angular/core';
import { Route, Router } from '@angular/router';
import { Product } from 'app/Admin/models/product';
import { ProductService } from 'app/Admin/services/product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss']
})
export class ProductListComponent implements OnInit {

  products: Product[] = [];
  colheaders: string[] = ["Id", "Name", "Price", "Category", "Subcategory", "Qty", "Actions"];
  totalRecords: number = 0;

  constructor(private router: Router, private productService: ProductService) { }

  ngOnInit(): void {
    this.productService.getProducts();
    this.productService.products.subscribe(data => {
      this.products = data;
      this.totalRecords = this.products.length;
    });

  }

  addProduct(): void {
    this.router.navigate(['/admin/add-products']);
  }

  editProduct(id: number): void {
    this.router.navigate(['/admin/edit-products', id]);
  }

  deleteProduct(id: number): void {
    this.productService.deleteProduct(id);
  }

}
