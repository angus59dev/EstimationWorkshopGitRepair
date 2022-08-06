import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RunningWorkshopComponent } from './running-workshop.component';

describe('RunningWorkshopComponent', () => {
  let component: RunningWorkshopComponent;
  let fixture: ComponentFixture<RunningWorkshopComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RunningWorkshopComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RunningWorkshopComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
