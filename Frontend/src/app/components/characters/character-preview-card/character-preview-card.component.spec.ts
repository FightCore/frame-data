import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CharacterPreviewCardComponent } from './character-preview-card.component';

describe('CharacterPreviewCardComponent', () => {
  let component: CharacterPreviewCardComponent;
  let fixture: ComponentFixture<CharacterPreviewCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CharacterPreviewCardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CharacterPreviewCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
