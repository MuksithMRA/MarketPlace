import { Component, OnInit, Input } from '@angular/core';
import { UtilsService } from '../../services/utils.service';

@Component({
  selector: 'app-base-layout',
  templateUrl: './base-layout.component.html',
  styleUrls: ['./base-layout.component.scss']
})



export class BaseLayoutComponent implements OnInit {

  isSideBarCollapsed = false;
  isSideBarLocked = true;

  constructor(private utilServices: UtilsService) {
  }

  ngOnInit(): void {
    this.utilServices.isSideBarCollapsed.subscribe((isCollapsed: boolean) => this.isSideBarCollapsed = isCollapsed);
    this.utilServices.isSideBarLocked.subscribe((isLocked: boolean) => this.isSideBarLocked = isLocked);
  }



}
