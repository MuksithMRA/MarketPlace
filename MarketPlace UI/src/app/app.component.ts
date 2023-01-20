import { Component } from '@angular/core';
import { UtilsService } from './Admin/services/utils.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  isSideBarCollapsed = false;
  isSideBarLocked = true;

  constructor(private utilServices: UtilsService) {
  }

  ngOnInit(): void {
    this.utilServices.isSideBarCollapsed.subscribe((isCollapsed: boolean) => this.isSideBarCollapsed = isCollapsed);
    this.utilServices.isSideBarLocked.subscribe((isLocked: boolean) => this.isSideBarLocked = isLocked);
  }
}
