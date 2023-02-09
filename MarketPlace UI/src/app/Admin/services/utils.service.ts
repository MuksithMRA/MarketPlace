import { Injectable, Output, EventEmitter } from '@angular/core';
import { Router } from '@angular/router';
import { StorageKeys } from 'app/Core/constants/storage-keys';
import { LocalStorageService } from 'app/Core/services/local-storage.service';

@Injectable({
  providedIn: 'root'
})
export class UtilsService {

  @Output() isSideBarCollapsed: EventEmitter<boolean> = new EventEmitter();
  @Output() isSideBarLocked: EventEmitter<boolean> = new EventEmitter();

  constructor(
    private localStorageService: LocalStorageService,
    private router: Router
  ) { }

  toggleSideBar(isCollapsed: boolean): void {
    this.isSideBarCollapsed.emit(isCollapsed);
  }

  toggleSideBarLock(isLocked: boolean): void {
    this.isSideBarLocked.emit(isLocked);
  }

  jwtToRole(jwt: string): string {
    if (jwt == null) {
      return '';
    }
    const jwtParts = jwt.split('.');
    const jwtPayload = JSON.parse(atob(jwtParts[1]));
    return jwtPayload.role;
  }

  checkIfloggedIn(path: string): boolean {
    let jwt = this.localStorageService.get(StorageKeys.TOKEN);
    if (jwt == null) {
      this.localStorageService.remove(StorageKeys.TOKEN);
      this.router.navigate(['/login']);
      return false;
    }
    const jwtParts = jwt.split('.');
    const jwtPayload = JSON.parse(atob(jwtParts[1]));
    const now = new Date();
    const exp = new Date(jwtPayload.exp * 1000);
    if (now > exp) {
      this.localStorageService.remove(StorageKeys.TOKEN);
      this.router.navigate(['/login']);
      return false;
    }
    this.router.navigate([path]);
    return true;
  }
}
