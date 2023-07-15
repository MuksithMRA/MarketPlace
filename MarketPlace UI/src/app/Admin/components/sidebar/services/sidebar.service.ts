import { Injectable } from '@angular/core';
import { Route, Router } from '@angular/router';
import { SidebarButton } from '../models/sidebar-button';

@Injectable({
  providedIn: 'root'
})
export class SidebarService {

  sidebarButtons: SidebarButton[] = [
    {
      title: 'Dashboard',
      leadingIcon: 'assets/dashboard.svg',
      route: '/admin/dashboard',
      isSelected: true,
      isDropdown: false,
    },
    {
      title: 'Products',
      leadingIcon: 'assets/product.svg',
      route: '/admin/products',
      isSelected: false,
      isDropdown: true,
      dropdownItems: [
        {
          title: 'Product List',
          route: '/admin/products',
          isSelected: false
        },
        {
          title: 'Add Product',
          route: '/admin/add-products',
          isSelected: false
        },
        {
          title: 'Category List',
          route: '/admin/categories',
          isSelected: false
        },
        {
          title: 'Add Category',
          route: '/admin/add-category',
          isSelected: false
        },
        {
          title: 'Brand List',
          route: '/admin/brands',
          isSelected: false
        },
        {
          title: 'Add Brand',
          route: '/admin/add-brand',
          isSelected: false
        },
        {
          title: 'Import Product',
          route: '/admin/import-product',
          isSelected: false
        },
        {
          title: 'Print Barcode',
          route: '/admin/barcode',
          isSelected: false
        },
      ]
    },

    {
      title: 'Sales',
      leadingIcon: 'assets/sales.svg',
      route: '/admin/sales',
      isSelected: false,
      isDropdown: true,
      dropdownItems: [
        {
          title: 'Sales List',
          route: '/admin/sales',
          isSelected: false
        },
        {
          title: 'POS',
          route: '/admin/pos',
          isSelected: false
        },

      ]
    },
  ];

  constructor(private router: Router) { }


  onClickSidebarButton(route: string): void {
    console.log(route);
    this.sidebarButtons.forEach(button => {
      if (!button.isDropdown) {
        if (button.route === route) {
          button.isSelected = true;
          this.router.navigate([route]);
        } else {
          button.isSelected = false;
        }
      } else {
        button.dropdownItems!.forEach(item => {
          if (item.route === route) {
            this.router.navigate([route]);
            item.isSelected = true;
          } else {
            item.isSelected = false;
          }
        });
      }
    });
  }

  closeAllDropdowns(): void {
    this.sidebarButtons.forEach(button => {
      if (button.isDropdown) {
        button.isSelected = false;
      }
    });
  }

  toggleDropDown(i: number) {
    for (let index = 0; index < this.sidebarButtons.length; index++) {
      if (index == i) {
        this.sidebarButtons[index].isSelected = !this.sidebarButtons[index].isSelected;
      }
    }
  }
}
