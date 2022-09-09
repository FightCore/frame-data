import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CompareCharactersComponent } from './compare-characters.component';

describe('CompareCharactersComponent', () => {
  let component: CompareCharactersComponent;
  let fixture: ComponentFixture<CompareCharactersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CompareCharactersComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CompareCharactersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
