import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductAddCategoryComponent } from './product-add-category.component';

describe('ProductAddCategoryComponent', () => {
  let component: ProductAddCategoryComponent;
  let fixture: ComponentFixture<ProductAddCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductAddCategoryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductAddCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
