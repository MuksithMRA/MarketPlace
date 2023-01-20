import { Component, OnInit } from '@angular/core';
import { Category } from 'app/Admin/models/category';
import { CategoryService } from 'app/Admin/services/category.service';

@Component({
  selector: 'app-product-category-list',
  templateUrl: './product-category-list.component.html',
  styleUrls: ['./product-category-list.component.scss']
})
export class ProductCategoryListComponent implements OnInit {

  constructor(private categoryService: CategoryService) { }
  categories: Category[] = [];
  colheaders: string[] = ["Id", "Description", "Sub Categories", "Actions"];

  ngOnInit(): void {
    this.categoryService.getCategories().subscribe(data => {
      this.categories = data;
    })
  }

  addCategory(): void { }

  editCategory(id: number): void { }

  deleteCategory(id: number): void { }

}
