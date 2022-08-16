import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CharacterQuickPickerComponent } from './character-quick-picker.component';

describe('CharacterQuickPickerComponent', () => {
  let component: CharacterQuickPickerComponent;
  let fixture: ComponentFixture<CharacterQuickPickerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CharacterQuickPickerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CharacterQuickPickerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
