import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BaseLayoutComponent } from './Admin/components/base-layout/base-layout.component';
import { DashboardComponent } from './Admin/components/dashboard/dashboard.component';
import { AddProductComponent } from './Admin/components/products/add-product/add-product.component';
import { ProductListComponent } from './Admin/components/products/product-list/product-list.component';
import { PosComponent } from './Admin/components/sales/pos/pos.component';
import { ProductCategoryListComponent } from './Admin/components/products/product-category-list/product-category-list.component';
import { ProductAddCategoryComponent } from './Admin/components/products/product-add-category/product-add-category.component';
import { LoginComponent } from './common/components/login/login.component';


const routes: Routes = [
  { path: '', redirectTo: 'admin', pathMatch: 'full' },
  {
    path: 'admin', component: BaseLayoutComponent, children: [
      { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
      { path: 'dashboard', component: DashboardComponent },
      { path: 'products', component: ProductListComponent },
      { path: 'add-products', component: AddProductComponent },
      { path: 'categories', component: ProductCategoryListComponent },
      { path: 'add-category', component: ProductAddCategoryComponent },
    ]
  },
  { path: 'pos', component: PosComponent },
  { path: 'login', component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
