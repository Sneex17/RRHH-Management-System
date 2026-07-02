import { type Sexos } from "../Entities/Sexos";
import { type cuerpoData } from "@/Controllers/Apis";

export async function ListaSexos(): Promise<cuerpoData[]> {
  const response = await fetch("https://localhost:7001/sexos/lista-sexos");
  const data = (await response.json()) as Sexos[];
  const listaSexos: Sexos[] = data;

  const sexos: cuerpoData[] = listaSexos.map((L) => {
    return {
      id: L.SexoId,
      nombre: L.Sexo,
    };
  });

  return sexos;
}
