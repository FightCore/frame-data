import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoveAttributesListComponent } from './move-attributes-list.component';

describe('MoveAttributesListComponent', () => {
  let component: MoveAttributesListComponent;
  let fixture: ComponentFixture<MoveAttributesListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MoveAttributesListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MoveAttributesListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
