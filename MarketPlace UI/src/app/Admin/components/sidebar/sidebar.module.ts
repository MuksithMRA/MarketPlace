import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidebarButtonComponent } from './components/sidebar-button/sidebar-button.component';
import { SidebarComponent } from './sidebar.component';



@NgModule({
  declarations: [
    SidebarButtonComponent
  ],
  imports: [
    CommonModule,

  ],
  providers: [],
  bootstrap: [SidebarComponent],
  exports: [
    SidebarButtonComponent
  ]
})
export class SidebarModule { }
