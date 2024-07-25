import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearVentasComponent } from './crear-ventas.component';

describe('CrearVentasComponent', () => {
  let component: CrearVentasComponent;
  let fixture: ComponentFixture<CrearVentasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CrearVentasComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CrearVentasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
