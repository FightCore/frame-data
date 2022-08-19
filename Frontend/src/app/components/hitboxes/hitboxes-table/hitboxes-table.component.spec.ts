import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HitboxesTableComponent } from './hitboxes-table.component';

describe('HitboxesTableComponent', () => {
  let component: HitboxesTableComponent;
  let fixture: ComponentFixture<HitboxesTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HitboxesTableComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HitboxesTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
