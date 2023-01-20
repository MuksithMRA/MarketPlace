import { EventEmitter, Injectable, Output } from '@angular/core';
import { Category } from '../models/category';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private http: HttpClient) { }

  @Output() categories = new EventEmitter<Category[]>();

  getCategories():Observable<Category[]> {
    this.http.get("assets/categories.json").subscribe(data => {
      this.categories.emit(data as Category[])
    });
    return this.categories;
  }
}
