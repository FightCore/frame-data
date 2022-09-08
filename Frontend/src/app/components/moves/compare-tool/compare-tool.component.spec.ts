import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CompareToolComponent } from './compare-tool.component';

describe('CompareToolComponent', () => {
  let component: CompareToolComponent;
  let fixture: ComponentFixture<CompareToolComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CompareToolComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CompareToolComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
