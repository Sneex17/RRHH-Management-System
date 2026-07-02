import { type EstadosCiviles } from "@/Entities/EstadosCiviles";
import { type cuerpoData } from "./Apis";

export async function ListaEstadosCiviles(): Promise<cuerpoData[]> {
  const response = await fetch("https://localhost:7001/estadosCiviles/lista-estadoCivil");
  const data = (await response.json()) as EstadosCiviles[];

  const listaEstadoCivil: EstadosCiviles[] = data;

  const estadosCiviles: cuerpoData[] = listaEstadoCivil.map((L) => {
    return {
      id: L.EstadoCivilId,
      nombre: L.EstadoCivil,
    };
  });

  return estadosCiviles;
}
