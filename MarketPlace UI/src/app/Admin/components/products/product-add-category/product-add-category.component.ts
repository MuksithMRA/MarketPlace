import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-add-category',
  templateUrl: './product-add-category.component.html',
  styleUrls: ['./product-add-category.component.scss']
})
export class ProductAddCategoryComponent implements OnInit {

  constructor() { }

  subCategories: string[] = [];

  ngOnInit(): void {
  }

}
