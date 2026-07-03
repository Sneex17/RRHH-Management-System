import { type Departamentos } from "../Entities/Departamentos";
import { type cuerpoData } from "./Apis";

export async function ListaDepartamento(): Promise<cuerpoData[]> {
  const response = await fetch("https://localhost:7001/departamentos/lista");
  const data = (await response.json()) as Departamentos[];
  const ListaDepartamento: Departamentos[] = data;
  const departamento: cuerpoData[] = ListaDepartamento.map((L) => {
    return {
      id: L.DepartamentoId,
      nombre: L.Nombre,
    };
  });

  return departamento;
}
