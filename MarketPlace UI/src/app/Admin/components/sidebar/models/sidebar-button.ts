import { SidebarDropdownItem } from "./sidebar-dropdown-item";

export interface SidebarButton {
    leadingIcon: string;
    title: string;
    route: string;
    isSelected: boolean;
    event?: void;
    isDropdown: boolean;
    dropdownItems?: SidebarDropdownItem[];

}
