import { Component, Input, OnInit } from '@angular/core';
import { UtilsService } from 'app/Admin/services/utils.service';
import { SidebarButton } from '../../models/sidebar-button';
import { SideBarChildrenService } from '../../services/side-bar-children.service';
import { SidebarService } from '../../services/sidebar.service';

@Component({
  selector: 'app-sidebar-button',
  templateUrl: './sidebar-button.component.html',
  styleUrls: ['./sidebar-button.component.scss']
})
export class SidebarButtonComponent implements OnInit {

  @Input() sidebarButton: SidebarButton = {} as SidebarButton;

  @Input() btnIndex: number = 0;

  isCollapse: boolean = false;


  constructor(private utilService: UtilsService, private sidebarChildrenService: SideBarChildrenService, private sidebarService: SidebarService) {
  }

  ngOnInit(): void {
    this.sidebarButton = this.sidebarService.sidebarButtons[this.btnIndex!];
    this.utilService.isSideBarCollapsed.subscribe((isCollapsed: boolean) => this.isCollapse = isCollapsed);
    if (this.isCollapse) {
      this.sidebarButton.isSelected = false;
    }
  }

  onDropDown(): void {
    if (this.sidebarButton.isDropdown) {
      this.sidebarButton.isSelected = !this.sidebarButton.isSelected;
      this.sidebarChildrenService.toggleDropDown(this.sidebarButton.isSelected);
    } else {
      this.sidebarService.onClickSidebarButton(this.sidebarButton.route);
    }
  }

  onSubItemClicked(index: number): void {
    this.sidebarService.onClickSidebarButton(this.sidebarButton.dropdownItems![index].route);
  }

}
