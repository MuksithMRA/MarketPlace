import { Injectable, EventEmitter } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SideBarChildrenService {

  isDropDownActive: EventEmitter<boolean> = new EventEmitter();
  isSubItemActive: EventEmitter<boolean> = new EventEmitter();



  constructor() { }

  toggleDropDown(isDropdowned: boolean): void {
    this.isDropDownActive.emit(isDropdowned);
  }
  onSubItemSelected(isSelected: boolean): void {
    this.isSubItemActive.emit(isSelected);
  }
}
