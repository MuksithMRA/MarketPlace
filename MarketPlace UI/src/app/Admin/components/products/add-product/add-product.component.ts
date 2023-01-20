import { Component, Input, OnInit } from '@angular/core';
import { Category } from 'app/Admin/models/category';
import { CategoryService } from 'app/Admin/services/category.service';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.scss']
})
export class AddProductComponent implements OnInit {

  constructor(private categoryService: CategoryService) { }
  categories: Category[] = [];
  selectedCategory?: number;
  subCategories: string[] = [];
  selectedSubCategory?: string;

  ngOnInit(): void {
    this.categoryService.categories.subscribe(data => {
      this.categories = data;
      this.selectedCategory = this.categories[0].id;
      if (this.selectedCategory != undefined) {
        this.loadSubCategories();
      }
    })
  }

  loadSubCategories() {
    this.subCategories = this.categories.find(c => c.id == this.selectedCategory)!.subcategories;
  }

}
