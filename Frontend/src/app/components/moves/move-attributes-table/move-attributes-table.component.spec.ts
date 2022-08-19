import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoveAttributesTableComponent } from './move-attributes-table.component';

describe('MoveAttributesTableComponent', () => {
  let component: MoveAttributesTableComponent;
  let fixture: ComponentFixture<MoveAttributesTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MoveAttributesTableComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MoveAttributesTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
