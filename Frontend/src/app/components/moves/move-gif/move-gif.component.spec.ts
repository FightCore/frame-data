import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MoveGifComponent } from './move-gif.component';

describe('MoveGifComponent', () => {
  let component: MoveGifComponent;
  let fixture: ComponentFixture<MoveGifComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MoveGifComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MoveGifComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
