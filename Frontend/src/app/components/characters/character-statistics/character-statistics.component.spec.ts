import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CharacterStatisticsComponent } from './character-statistics.component';

describe('CharacterStatisticsComponent', () => {
  let component: CharacterStatisticsComponent;
  let fixture: ComponentFixture<CharacterStatisticsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CharacterStatisticsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CharacterStatisticsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
