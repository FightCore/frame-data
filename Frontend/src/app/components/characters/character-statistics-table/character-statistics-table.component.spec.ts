import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CharacterStatisticsTableComponent } from './character-statistics-table.component';

describe('CharacterStatisticsTableComponent', () => {
  let component: CharacterStatisticsTableComponent;
  let fixture: ComponentFixture<CharacterStatisticsTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CharacterStatisticsTableComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CharacterStatisticsTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
