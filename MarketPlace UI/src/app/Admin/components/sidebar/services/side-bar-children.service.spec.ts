import { TestBed } from '@angular/core/testing';

import { SideBarChildrenService } from './side-bar-children.service';

describe('SideBarChildrenService', () => {
  let service: SideBarChildrenService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SideBarChildrenService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
