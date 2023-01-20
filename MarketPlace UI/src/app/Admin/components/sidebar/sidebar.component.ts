import { Component, OnInit } from '@angular/core';
import { UtilsService } from '../../services/utils.service';
import { SidebarButton } from './models/sidebar-button';
import { SideBarChildrenService } from './services/side-bar-children.service';
import { SidebarService } from './services/sidebar.service';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent implements OnInit {

  isCollapse: boolean = false;
  isLocked: boolean = true;
  sidebarButtons: SidebarButton[] = [];

  constructor(
    private utilService: UtilsService,
    private sideBarService: SidebarService
  ) { }

  ngOnInit(): void {
    this.sidebarButtons = this.sideBarService.sidebarButtons;
  }

  lockSideBar(): void {
    this.isLocked = !this.isLocked;
    this.utilService.toggleSideBarLock(this.isLocked);
  }

  onCollapse(): void {
    this.isCollapse = !this.isCollapse;
    this.utilService.toggleSideBar(this.isCollapse);
  }

  onMouseEnter(): void {
    if (!this.isLocked) {
      if (this.isCollapse) {
        this.onCollapse();
      }
    }
  }

  onMouseLeave(): void {
    if (!this.isLocked) {
      if (!this.isCollapse) {
        this.isCollapse = true;
        this.utilService.toggleSideBar(this.isCollapse);
      }
    }

  }

}
