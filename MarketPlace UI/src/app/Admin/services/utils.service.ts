import { Injectable, Output, EventEmitter } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UtilsService {

  @Output() isSideBarCollapsed: EventEmitter<boolean> = new EventEmitter();
  @Output() isSideBarLocked: EventEmitter<boolean> = new EventEmitter();

  constructor() { }

  toggleSideBar(isCollapsed: boolean): void {
    this.isSideBarCollapsed.emit(isCollapsed);
  }

  toggleSideBarLock(isLocked: boolean): void {
    this.isSideBarLocked.emit(isLocked);
  }
}
