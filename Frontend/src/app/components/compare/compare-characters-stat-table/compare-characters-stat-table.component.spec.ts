import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CompareCharactersStatTableComponent } from './compare-characters-stat-table.component';

describe('CompareCharactersStatTableComponent', () => {
  let component: CompareCharactersStatTableComponent;
  let fixture: ComponentFixture<CompareCharactersStatTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CompareCharactersStatTableComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CompareCharactersStatTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
