import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SidebarComponent } from './Admin/components/sidebar/sidebar.component';
import { DashboardComponent } from './Admin/components/dashboard/dashboard.component';
import { NavAdminComponent } from './Admin/components/nav-admin/nav-admin.component';
import { BaseLayoutComponent } from './Admin/components/base-layout/base-layout.component';
import { ButtonModule } from 'primeng/button';
import { ListboxModule } from 'primeng/listbox';
import { SidebarModule } from './Admin/components/sidebar/sidebar.module';
import { CardModule } from 'primeng/card';
import { ProductListComponent } from './Admin/components/products/product-list/product-list.component';
import { AddProductComponent } from './Admin/components/products/add-product/add-product.component';
import { ProductCategoryListComponent } from './Admin/components/products/product-category-list/product-category-list.component';
import { ProductAddCategoryComponent } from './Admin/components/products/product-add-category/product-add-category.component';
import { SalesListComponent } from './Admin/components/sales/sales-list/sales-list.component';
import { PosComponent } from './Admin/components/sales/pos/pos.component';
import { AvatarModule } from 'primeng/avatar';
import { CarouselModule } from 'primeng/carousel';
import { VirtualScrollerModule } from 'primeng/virtualscroller';
import { CommonHeaderComponent } from './common/components/common-header/common-header.component';
import { TableModule } from 'primeng/table';
import { MultiSelectModule } from 'primeng/multiselect';
import { InputTextModule } from 'primeng/inputtext';
import { ToastModule } from 'primeng/toast';
import { ToolbarModule } from 'primeng/toolbar';
import { FileUploadModule } from 'primeng/fileupload';
import { HttpClientModule } from '@angular/common/http';
import { RatingModule } from 'primeng/rating';
import { DialogModule } from 'primeng/dialog';
import { DropdownModule } from 'primeng/dropdown';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { ScrollPanelModule } from 'primeng/scrollpanel';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ChipModule } from 'primeng/chip';
import { ChipsModule } from 'primeng/chips';
import { CheckboxModule } from 'primeng/checkbox';
import { LoginComponent } from './common/components/login/login.component';
import { CommonValidationMessageComponent } from './common/components/common-validation-message/common-validation-message.component';
@NgModule({
  declarations: [
    AppComponent,
    SidebarComponent,
    DashboardComponent,
    NavAdminComponent,
    BaseLayoutComponent,
    ProductListComponent,
    AddProductComponent,
    ProductCategoryListComponent,
    ProductAddCategoryComponent,
    SalesListComponent,
    PosComponent,
    CommonHeaderComponent,
    LoginComponent,
    CommonValidationMessageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ButtonModule,
    ListboxModule,
    SidebarModule,
    CardModule,
    AvatarModule,
    CarouselModule,
    VirtualScrollerModule,
    TableModule,
    MultiSelectModule,
    InputTextModule,
    ToastModule,
    ToolbarModule,
    FileUploadModule,
    HttpClientModule,
    RatingModule,
    DialogModule,
    DropdownModule,
    InputTextareaModule,
    ScrollPanelModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    ChipModule,
    ChipsModule,
    CheckboxModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
