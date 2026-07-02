import { type Estados } from "@/Entities/Estados";
import { type cuerpoData } from "./Apis";

export async function ListaEstados(): Promise<cuerpoData[]> {
  const response = await fetch("https://localhost:7001/estados/lista-estados");
  const data = (await response.json()) as Estados[];
  const listaEstados: Estados[] = data;

  const estados: cuerpoData[] = listaEstados.map((L) => {
    return {
      id: L.EstadoId,
      nombre: L.Estado,
    };
  });

  return estados;
}
