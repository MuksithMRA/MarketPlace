import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommonValidationMessageComponent } from './common-validation-message.component';

describe('CommonValidationMessageComponent', () => {
  let component: CommonValidationMessageComponent;
  let fixture: ComponentFixture<CommonValidationMessageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CommonValidationMessageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CommonValidationMessageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
