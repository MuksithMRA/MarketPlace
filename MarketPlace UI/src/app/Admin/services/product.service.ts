import { EventEmitter, Injectable, Output } from '@angular/core';
import { Product } from '../models/product';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }
  @Output() products = new EventEmitter<Product[]>();

  getProducts(): Observable<Product[]> {
    this.http.get("assets/products.json").subscribe(data => {
      this.products.emit(data as Product[])
    });
    return this.products;
  }

  deleteProduct(id: number) {
    this.products.subscribe(data => data.filter(p => p.id != id))
    this.products.emit();
  }
}
