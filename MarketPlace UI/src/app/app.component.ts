import { Component } from '@angular/core';
import { UtilsService } from './Admin/services/utils.service';
import { LocalStorageService } from './Core/services/local-storage.service';
import { Router } from '@angular/router';
import { StorageKeys } from './Core/constants/storage-keys';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  isSideBarCollapsed = false;
  isSideBarLocked = true;

  constructor(
    private utilServices: UtilsService,
    private localStorageService: LocalStorageService,
    private router: Router
  ) {
  }

  ngOnInit(): void {
    this.utilServices.isSideBarCollapsed.subscribe((isCollapsed: boolean) => this.isSideBarCollapsed = isCollapsed);
    this.utilServices.isSideBarLocked.subscribe((isLocked: boolean) => this.isSideBarLocked = isLocked);
    this.utilServices.checkIfloggedIn('/admin');
  }
}
